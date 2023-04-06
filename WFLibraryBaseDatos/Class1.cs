using System.Configuration;


namespace WFLibraryBaseDatos
{
    public static class Class1
    {
        public static string connetionstrings = ConfigurationManager.ConnectionStrings["StringKey"].ConnectionString;
    }
}