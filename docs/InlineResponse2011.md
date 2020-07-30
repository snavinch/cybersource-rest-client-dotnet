# CyberSource.Model.InlineResponse2011
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by authorization service.  #### PIN debit Time when the PIN debit credit, PIN debit purchase or PIN debit reversal was requested.  Returned by PIN debit credit, PIN debit purchase or PIN debit reversal.  | [optional] 
**Status** | **string** | The status of the submitted transaction.  Possible values:  - ACCEPTED  | [optional] 
**ClientReferenceInformation** | [**Kmsv2keyssymClientReferenceInformation**](Kmsv2keyssymClientReferenceInformation.md) |  | [optional] 
**KeyInformation** | [**List&lt;InlineResponse2011KeyInformation&gt;**](InlineResponse2011KeyInformation.md) |  | [optional] 
**CertificateInformation** | [**List&lt;InlineResponse2011CertificateInformation&gt;**](InlineResponse2011CertificateInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
