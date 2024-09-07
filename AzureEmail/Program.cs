using Azure;
using Azure.Communication.Email;

// This code retrieves your connection string from an environment variable.
string connectionString = "COMMUNICATION_SERVICES_CONNECTION_STRING";
var emailClient = new EmailClient(connectionString);


EmailSendOperation emailSendOperation = emailClient.Send(
    WaitUntil.Completed,
    senderAddress: "DoNotReply@c7809194-168e-4f18-b421-fd337cb7789b.azurecomm.net",
    recipientAddress: "myemail@emaildomain.com",
    subject: "Test Email",
    htmlContent: "<html><h1>Hello world via email.</h1l></html>",
    plainTextContent: "Hello world via email.");
