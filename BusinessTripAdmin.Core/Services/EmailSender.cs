using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Reflection;

namespace BusinessTripAdmin.Core.Services;

public class EmailSender : IEmailSender
{
    private readonly IConfiguration _configuration;

    public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, IConfiguration configuration)
    {
        Options = optionsAccessor.Value;
        _configuration = configuration;
    }

    public AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        await Execute(subject, message, toEmail);
    }

    public async Task Execute(string subject, string message, string toEmail)
    {
        var apiKey = _configuration.GetValue<string>("SendGridApiKey");
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("p.nikollov@students.softuni.bg");
        var to = new EmailAddress(toEmail);
        var htmlContent = await ReadResetPasswordTemplate();
        var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        var response = await client.SendEmailAsync(msg);
    }

    private async Task<string> ReadResetPasswordTemplate()
    {
        var baseDirectory = Environment.CurrentDirectory;
        var uri = new UriBuilder(baseDirectory);
        var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path));
        var templateFilePath = @$"{path}\BusinessTripAdmin.Core\ResetPasswordHtml.txt";
        var lines = string.Empty;
        using (var streamReader = new StreamReader(templateFilePath))
        {
            lines = await streamReader.ReadToEndAsync();
        }

        return lines;
    }
}