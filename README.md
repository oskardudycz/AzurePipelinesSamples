# Azure Pipelines Samples
Azure Pipeline Samples

## Sample Library Flow

### 1. Build

    ![Build](Library/assets/01_build_step.png)

### 2. Test

    ![Build](Library/assets/02_test_step.png)

### 3. Publish NuGet

    ![Build](Library/assets/03_publish_step.png)

### 4. Contract test with prerelease NuGet

    ![Build](Library/assets/04_contract_tests_step.png)

### 5. Release NuGet

    ![Build](Library/assets/05_release_step.png)


### 6. Whole flow

    ![Build](Library/assets/Library-Flow-Diagram.png)

See full configuration in the [azure-pipelines.yml](Library/azure-pipelines.yml)

## Other Resources

1. Integrate GitHub repository with AzureDevops: https://www.azuredevopslabs.com/labs/azuredevops/github-integration/

2. Setup AzureDevops for .NET Core build: 
- https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops
- https://www.hanselman.com/blog/SettingUpAzureDevOpsCICDForANETCore31WebAppHostedInAzureAppServiceForLinux.aspx
- https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/build/dotnet-core-cli?view=azure-devops
- https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/package/nuget?view=azure-devops

3. Connect with NuGet feed
- https://docs.microsoft.com/en-us/azure/devops/pipelines/library/service-endpoints?view=azure-devops&tabs=yaml

4. Publish NuGet package
- https://docs.microsoft.com/en-us/azure/devops/pipelines/artifacts/nuget?view=azure-devops&tabs=yaml
- https://stevenknox.net/auto-versioning-nuget-packages-in-azure-devops-pipelines/
- https://kasunkodagoda.com/2019/04/03/hidden-gems-in-azure-pipelines-creating-your-own-rev-variable-using-counter-expression-in-azure-pipelines/

5. Multi-platform build pipeline
- https://docs.microsoft.com/en-us/azure/devops/pipelines/get-started-multiplatform?view=azure-devops

6. Copy files between jobs:
- https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/utility/copy-files?view=azure-devops&tabs=yaml

7. Conditions:
- https://docs.microsoft.com/en-us/azure/devops/pipelines/process/conditions?view=azure-devops&tabs=yaml

8. Checking out multiple repos:
- https://docs.microsoft.com/en-us/azure/devops/pipelines/repos/multi-repo-checkout?view=azure-devops

9. Artifacts tasks:
- https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/utility/publish-build-artifacts?view=azure-devops
- https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/utility/download-build-artifacts?view=azure-devops

10. Templates:
- https://docs.microsoft.com/en-us/azure/devops/pipelines/process/templates?view=azure-devops