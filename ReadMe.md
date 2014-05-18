# .Net Api Wrapper with C# Example

This project contains our .Net Api Wrapper and a C# wrapper.  We have examples of using both XML and Json. 

## Sending a single account

The code is quite simple and can be read through to understand how it works. Your application only needs to make one async call to the `ClientApiWrapper.Controller.PostAccount(Account Object, Account Id, Username, Password, Submit Data Type)` function.

The complete example can be seen from `ClientApiExample.Test.btnSubmit_Click` or `ClientApiExample.Test.btnSubmitJson_Click`

## Sending a list of accounts

Similar to the PostAccount function, we also have a PostAccounts method which can take a list of accounts. It returns a list of ApiResponse.

`ClientApiWrapper.Controller.PostAccounts(List<Account> Object, Account Id, Username, Password, Submit Data Type)`


### API Documentation
For complete details on our API, please read https://developers.agencyrevolution.com
