public class DevOpenSpacePlugin
{
    [KernelFunction, Description("Gibt den Twitter Handle des Users anhand des Usernamens zurück")]
    public string GetUsersTwitterHandle([Description("Der Username des Users")] string input)
    {
        return $"@{input}";
    }

    [KernelFunction, Description("Gibt die Anzahl der User bei der Veranstaltung DevOpenSpace zurück")]
    public int GetUsersCount()
    {
        return 120;
    }
}