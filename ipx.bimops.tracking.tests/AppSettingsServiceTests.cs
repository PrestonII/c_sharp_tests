using System.Runtime;
using NUnit.Framework;

namespace ipx.bimops.tracking.tests;

public class AppSettingsServiceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldBeAbleToGetCreds()
    {
        var creds = new AppSettings
        {
            AirtableAPIKey = "your-airtable-key",
            AirtableBaseTrackingId = "your-airtable-base-id",
            AirtableTrackingTableId = "your-airtable-table-id",
            AirtableTrackingTableId_Testing = "your-airtable-table-id-testing"
        };

        var result = AppSettingsService.GetCreds("appsettings.sample.json");

        Assert.That(result.AirtableAPIKey, Is.EqualTo(creds.AirtableAPIKey));
        Assert.That(result.AirtableBaseTrackingId, Is.EqualTo(creds.AirtableBaseTrackingId));
        Assert.That(result.AirtableTrackingTableId, Is.EqualTo(creds.AirtableTrackingTableId));
        Assert.That(result.AirtableTrackingTableId_Testing, Is.EqualTo(creds.AirtableTrackingTableId_Testing));
    }

    [Test]
    public void ShouldThrowAnExceptionIfNoCredentialFileIsGivem()
    {
        Assert.Throws<Exception>(() => AppSettingsService.GetCreds());
    }
}
