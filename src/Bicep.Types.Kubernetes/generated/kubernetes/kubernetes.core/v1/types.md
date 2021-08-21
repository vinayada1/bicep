# kubernetes.core @ v1

## Resource ConfigMap@v1
* **Valid Scope(s)**: Unknown
### Properties
* **apiVersion**: 'v1' (ReadOnly, DeployTimeConstant): The api version.
* **binaryData**: [IoK8SApiCoreV1ConfigMapBinaryData](#iok8sapicorev1configmapbinarydata): BinaryData contains the binary data. Each key must consist of alphanumeric characters, '-', '_' or '.'. BinaryData can contain byte sequences that are not in the UTF-8 range. The keys stored in BinaryData must not overlap with the ones in the Data field, this is enforced during validation process. Using this field will require 1.10+ apiserver and kubelet.
* **data**: [IoK8SApiCoreV1ConfigMapData](#iok8sapicorev1configmapdata): Data contains the configuration data. Each key must consist of alphanumeric characters, '-', '_' or '.'. Values with non-UTF-8 byte sequences must use the BinaryData field. The keys stored in Data must not overlap with the keys in the BinaryData field, this is enforced during validation process.
* **immutable**: bool: Immutable, if set to true, ensures that data stored in the ConfigMap cannot be updated (only object metadata can be modified). If not set to true, the field can be modified at any time. Defaulted to nil. This is a beta field enabled by ImmutableEphemeralVolumes feature gate.
* **kind**: 'ConfigMap' (ReadOnly, DeployTimeConstant): The resource kind.
* **metadata**: [metadata](#metadata) (Required): The resource metadata.

## IoK8SApiCoreV1ConfigMapBinaryData
### Properties
### Additional Properties
* **Additional Properties Type**: any

## IoK8SApiCoreV1ConfigMapData
### Properties
### Additional Properties
* **Additional Properties Type**: string

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

