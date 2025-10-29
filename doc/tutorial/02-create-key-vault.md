# II) Create the Key Vault

## 1) Access the Azure Portal

- `https://portal.azure.com`

## 2) Create a resource

![Create a resource](create-resource-group-01-create-a-resource.png)

## 3) Choose "Key Vault"

![Create Key Vault](create-key-vault-02-key-vault.png)

## 4) Configure

### Basic

- Choose the Subscription (I am using the "Visual Studio Professional Subscription")
- Choose the resource group: `key-vault-demo-rg`
- Key vault name: `key-vault-20251022-kv`
- Region: `West Europe`
  - Make sure it is the same region as the resource group

![Configure - Basic](create-key-vault-03-configure-basic.png)

### Access configuration

- Permission model: `Azure role-based access control (Azure RBAC)`

![Configure - Access configuration](create-key-vault-04-configure-access-configuration.png)

### Networking

- Accept default values

![Configure - Networking](create-key-vault-05-configure-networking.png)

### Review + create

- Click "Create" button

![Configure - Create](create-key-vault-06-configure-create.png)

