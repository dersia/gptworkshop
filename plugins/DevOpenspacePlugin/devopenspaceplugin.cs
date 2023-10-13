public class DevOpenSpacePlugin
{
    [SKFunction, Description("Gibt den Twitter Handle des Users anhand des Usernamens zurück")]
    public string GetUsersTwitterHandle([Description("Der Username des Users")] string input)
    {
        return $"@{input}";
    }

    [SKFunction, Description("Gibt die Anzahl der User bei der Veranstaltung DevOpenSpace zurück")]
    public int GetUsersCount()
    {
        return 120;
    }
}