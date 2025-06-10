#!/usr/bin/env bash
set -e

# Build and launch the MAUI app. The default framework is Android.
# Adjust the -f parameter to target a different platform.

dotnet workload restore BudgetSaver/BudgetSaver.csproj

dotnet build BudgetSaver/BudgetSaver.csproj -t:Run -f net8.0-android "$@"
