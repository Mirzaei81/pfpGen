using System.Net.Htpp;
Random rand = new();
string[] category = {
"Adventurer",
"Adventurer Neutral",
"Avataaars",
"Avataaars Neutral ",
"Big Ears",
"Big Ears Neutral",
"Big Smile",
"Bottts",
"Bottts Neutral",
"Croodles",
"CroodlesNeutral",
"FunEmoji",
"Icons",
"Identicon",
"Initials",
"Lorelei",
"LoreleiNeutral",
"Micah",
"Miniavs",
"Notionists",
"NotionistsNeutral",
"OpenPeeps",
"Personas",
"PixelArt",
"PixelArt Neutral",
"Shapes",
"Thumbs"}
int RIdx = rand.Next(category.Length);
string url = $"https://api.dicebear.com/6.x/{category[RIdx]}/svg";
private static readonly client = new HttpClient();

await  ProcessImageQuery(client,url);
static async Task ProcessImageQuery(HttpClient client,string url)
{
		var json = client.get(url);
		Console.WriteLine(json);
}
