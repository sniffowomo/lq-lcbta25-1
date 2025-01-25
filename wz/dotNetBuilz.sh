#!/usr/bin/bash
# This bash script builds a .NET project as a single executable for Windows and Linux.

clear

# Colors
export RED='\033[0;31m'
export GREEN='\033[0;32m'
export YELLOW='\033[0;33m'
export BLUE='\033[0;34m'
export PURPLE='\033[0;35m'
export CYAN='\033[0;36m'
export WHITE='\033[0;37m'
export NC='\033[0m' # No Color

# Function to display a header
header() {
    echo -e "${CYAN}=============== "
    echo -e "$1"
    echo -e "===============${NC}"
}

# Function to display a waiting animation
waiting_animation() {
    local pid=$1
    local delay=0.75
    local spinstr='|/-\'
    while [ "$(ps a | awk '{print $1}' | grep $pid)" ]; do
        local temp=${spinstr#?}
        printf " [%c]  " "$spinstr"
        local spinstr=$temp${spinstr%"$temp"}
        sleep $delay
        printf "\b\b\b\b\b\b"
    done
    printf "    \b\b\b\b"
}

# Function to build for a specific runtime
build_for_runtime() {
    local runtime=$1
    local platform_name=$2
    local build_command="dotnet publish -c Release -r $runtime --self-contained /p:PublishSingleFile=true /p:PublishTrimmed=true /p:TrimMode=link"

    echo -e ""
    echo -e "${PURPLE}[-] Building for $platform_name ${NC}"

    # Start the build process in the background
    $build_command >/dev/null 2>&1 &
    local build_pid=$!

    # Display a waiting animation while the build is running
    waiting_animation $build_pid

    # Wait for the build process to finish
    wait $build_pid
    local exit_status=$?

    if [ $exit_status -eq 0 ]; then
        echo -e "${GREEN}[+] $platform_name Build Finished Successfully ${NC}"
        return 0
    else
        echo -e "${RED}[!] $platform_name Build Failed ${NC}"
        return 1
    fi
}

# Main execution
header "Building Single Executable File for Windows and Linux"

# Build for Windows
if build_for_runtime "win-x64" "Windows"; then
    windows_success=true
else
    windows_success=false
fi

# Build for Linux
if build_for_runtime "linux-x64" "Linux"; then
    linux_success=true
else
    linux_success=false
fi

# Display summary
header "Build Summary"
if $windows_success && $linux_success; then
    echo -e "${GREEN}[+] Both Windows and Linux builds completed successfully! ${NC}"
elif $windows_success; then
    echo -e "${YELLOW}[!] Windows build succeeded, but Linux build failed. ${NC}"
elif $linux_success; then
    echo -e "${YELLOW}[!] Linux build succeeded, but Windows build failed. ${NC}"
else
    echo -e "${RED}[!] Both Windows and Linux builds failed. ${NC}"
fi

echo -e ""
