using System.Net;

namespace Desktop_Application.Classes;

class HandleFiles
{
    internal static void Upload(string originalPath, string tempPath)
    {
        try
        {
            File.Copy(originalPath, tempPath, true);
            WebClient webClient = new();
            webClient.UploadFile("http://localhost:8000/api/upload-img", "POST", tempPath);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Something went wrong during file upload! Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (File.Exists(tempPath)) File.Delete(tempPath);
        }
    }
}