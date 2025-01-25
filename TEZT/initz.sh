#!/usr/bin/bash
# This bash script is for setting up a new .NET project or adding a project to an existing solution.

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

# Commands
b1() {
    echo -e "${CYAN}=============== "
    echo -e "Setting up a new .NET project with .NET 8.0"
    echo -e "===============${NC}"
}

b2() {
    echo -e "${GREEN}[?] Choose an option: (1) New Solution or (2) New Project in Existing Solution ${NC}"
    echo -e "${PURPLE}[*] Enter your choice (1 or 2): ${NC}"
    read -r choice
    if [ "$choice" == "1" ]; then
        c1
    elif [ "$choice" == "2" ]; then
        c2
    else
        echo -e "${RED}[!] Invalid choice. Please enter either '1' or '2'.${NC}"
        b2
    fi
}

c1() {
    # Starting a new project
    echo -e "${GREEN}[-] Enter the name of the new project: ${NC}"
    read -r project_name

    CO1="dotnet new console -n $project_name"
    CO2="eza -T $project_name"

    echo -e "${GREEN}[+] Creating project: $project_name ${NC}"

    # Execute the first command and capture the output and exit status
    output1=$($CO1 2>&1)
    exit_status1=$?

    if [ $exit_status1 -eq 0 ]; then
        echo -e "${GREEN}[+] Project '$project_name' created successfully ${NC}"
        echo -e "${GREEN}$output1${NC}"
    else
        echo -e "${RED}[!] Failed to create project '$project_name' ${NC}"
        echo -e "${RED}$output1${NC}"
        return 1
    fi

    # Execute the second command and capture the output and exit status
    output2=$($CO2 2>&1)
    exit_status2=$?

    if [ $exit_status2 -eq 0 ]; then
        echo -e "${GREEN}[+] eza command executed successfully ${NC}"
        echo -e "${GREEN}$output2${NC}"
    else
        echo -e "${RED}[!] Failed to execute eza command ${NC}"
        echo -e "${RED}$output2${NC}"
        return 1
    fi
}

c2() {
    # Adding a new project to an existing solution
    echo -e "${GREEN}[-] Enter the name of the new project to add to the existing solution: ${NC}"
    read -r project_name

    echo -e "${GREEN}[-] Enter the path to the existing solution file (.sln): ${NC}"
    read -r solution_path

    CO1="dotnet new classlib -n $project_name"
    CO2="dotnet sln $solution_path add $project_name"
    CO3="eza -T $project_name"

    echo -e "${GREEN}[+] Creating project: $project_name ${NC}"

    # Execute the first command and capture the output and exit status
    output1=$($CO1 2>&1)
    exit_status1=$?

    if [ $exit_status1 -eq 0 ]; then
        echo -e "${GREEN}[+] Project '$project_name' created successfully ${NC}"
        echo -e "${GREEN}$output1${NC}"
    else
        echo -e "${RED}[!] Failed to create project '$project_name' ${NC}"
        echo -e "${RED}$output1${NC}"
        return 1
    fi

    # Execute the second command to add the project to the solution
    output2=$($CO2 2>&1)
    exit_status2=$?

    if [ $exit_status2 -eq 0 ]; then
        echo -e "${GREEN}[+] Project '$project_name' added to solution successfully ${NC}"
        echo -e "${GREEN}$output2${NC}"
    else
        echo -e "${RED}[!] Failed to add project '$project_name' to the solution ${NC}"
        echo -e "${RED}$output2${NC}"
        return 1
    fi

    # Execute the third command and capture the output and exit status
    output3=$($CO3 2>&1)
    exit_status3=$?

    if [ $exit_status3 -eq 0 ]; then
        echo -e "${GREEN}[+] eza command executed successfully ${NC}"
        echo -e "${GREEN}$output3${NC}"
    else
        echo -e "${RED}[!] Failed to execute eza command ${NC}"
        echo -e "${RED}$output3${NC}"
        return 1
    fi
}

# Execution
b1
b2
