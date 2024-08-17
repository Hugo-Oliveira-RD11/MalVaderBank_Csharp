namespace Data;
public static class Data{
    private static int DefinedPath(){
        string folderName;
        folderName = System.Environment.CurrentDirectory + "/bank";
        bool exist= System.IO.Directory.Exists(folderName);
        if(exist){
            return 0;
        }
        System.IO.Directory.CreateDirectory(folderName);
        return 1;
    }
}
