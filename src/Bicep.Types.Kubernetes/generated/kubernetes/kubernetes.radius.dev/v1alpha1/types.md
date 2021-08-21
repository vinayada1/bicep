# kubernetes.radius.dev @ v1alpha1

## Resource radius.dev/Deployment@v1alpha1
* **Valid Scope(s)**: Unknown
### Properties
* **apiVersion**: 'radius.dev/v1alpha1' (ReadOnly, DeployTimeConstant): The api version.
* **kind**: 'Deployment' (ReadOnly, DeployTimeConstant): The resource kind.
* **metadata**: [metadata](#metadata) (Required): The resource metadata.
* **spec**: [DevRadiusV1Alpha1DeploymentSpec](#devradiusv1alpha1deploymentspec): DeploymentSpec defines the desired state of Deployment
* **status**: any: Any object

## metadata
### Properties
* **annotations**: [annotations](#annotations): The annotations for the resource.
* **labels**: [labels](#labels): The labels for the resource.
* **name**: string (Required, DeployTimeConstant): The name of the resource.
* **namespace**: string (DeployTimeConstant): The namespace of the resource.

## annotations
### Properties
* **annotations**: [annotations](#annotations): The annotations for the resource.
* **labels**: [labels](#labels): The labels for the resource.
* **name**: string (Required, DeployTimeConstant): The name of the resource.
* **namespace**: string (DeployTimeConstant): The namespace of the resource.
### Additional Properties
* **Additional Properties Type**: string

## labels
### Properties
* **annotations**: [annotations](#annotations): The annotations for the resource.
* **labels**: [labels](#labels): The labels for the resource.
* **name**: string (Required, DeployTimeConstant): The name of the resource.
* **namespace**: string (DeployTimeConstant): The namespace of the resource.
### Additional Properties
* **Additional Properties Type**: string

## DevRadiusV1Alpha1DeploymentSpec
### Properties
* **components**: [DevRadiusV1Alpha1DeploymentSpecComponentsItem](#devradiusv1alpha1deploymentspeccomponentsitem)[]: Array of dev.radius.v1alpha1.Deployment-spec-componentsItem
* **hierarchy**: string[]: Array of DevRadiusV1Alpha1DeploymentSpecHierarchyItem

## DevRadiusV1Alpha1DeploymentSpecComponentsItem
### Properties
* **componentName**: string (Required)

