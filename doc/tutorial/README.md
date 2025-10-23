# Azure Key Vault Demo

## I) Create the Azure Key Vault

The Key Vault needs to be created inside a resource group and then assign permissions to be able to access it from the local application.

1) [Create a new Resource Group](01-create-resource-group.md)
2) [Create a new Key Vault](02-create-key-vault.md)
3) [Assign permissions](03-assign-permissions.md)
   - In this example, the Azure user (an Active  Directory user) being assigned as "Key Vault administrator" to the newly created Key Vault must be the same user under which the local application (a console app) is running. That means the same user is used to authenticate in Windows locally.

## II) Access the Azure Key Vault

TBD (see the code)