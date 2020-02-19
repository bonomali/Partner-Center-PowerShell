---
content_git_url: https://github.com/Microsoft/Partner-Center-PowerShell/blob/master/docs/help/New-PartnerAzureSubscription.md
external help file: Microsoft.Store.PartnerCenter.PowerShell.dll-Help.xml
Module Name: PartnerCenter
online version: https://docs.microsoft.com/powershell/module/partnercenter/New-PartnerAzureSubscription
original_content_git_url: https://github.com/Microsoft/Partner-Center-PowerShell/blob/master/docs/help/New-PartnerAzureSubscription.md
schema: 2.0.0
---

# New-PartnerAzureSubscription

## SYNOPSIS
Creates a new Azure subscription under an Azure Plan for the specified customer.

## SYNTAX

```powershell
New-PartnerAzureSubscription -BillingAccountName <String> -CustomerId <String> -DisplayName <String>
 [-ResellerId <String>] [<CommonParameters>]
```

## DESCRIPTION
Creates a new Azure subscription under an Azure Plan for the specified customer.

## EXAMPLES

### Example 1
```powershell
PS C:\> $account = Get-PartnerAzureBillingAccount | ? {$_.AgreementType -eq 'MicrosoftCustomerAgreement'}
PS C:\> New-PartnerAzureSubscription -BillingAccountName $account.Name -DisplayName 'Microsoft Azure'
```

Creates a new Azure subscription under an Azure Plan for the specified customer.

## PARAMETERS

### -BillingAccountName
The name for the billing account.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerId
The identifier for the customer.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display for the subscription.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResellerId
The identifier for the indirect reseller.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Management.Profiles.Subscription.Models.SubscriptionCreationResult

## NOTES

## RELATED LINKS
