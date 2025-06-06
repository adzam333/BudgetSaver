#!/usr/bin/env bash
set -e

# Restore NuGet packages and required workloads for the MAUI app

dotnet workload restore BudgetSaver/BudgetSaver.csproj

dotnet restore BudgetSaver/BudgetSaver.sln
