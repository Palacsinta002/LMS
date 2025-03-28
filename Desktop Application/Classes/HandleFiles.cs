using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Desktop_Application.Classes;

struct ErrorResponse()
{
    [JsonPropertyName("error")]
    public string Error { get; set; }
}

class HandleFiles
{
    internal static bool Upload(string path)
    {
        try
        {
            using HttpClient httpClient = new();
            using MultipartFormDataContent form = [];
            using var fileStream = File.OpenRead(path);
            using StreamContent fileContent = new(fileStream);

            string extension = Path.GetExtension(path).Substring(1);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue($"image/{extension}");
            form.Add(fileContent, "image", Path.GetFileName(path));

            var response = httpClient.PostAsync("http://localhost:8000/api/upload-img", form).GetAwaiter().GetResult();
            string errorMsgJson = response.Content.ReadAsStringAsync().Result;
            ErrorResponse errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorMsgJson);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Upload successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                string errorMsg = errorResponse.Error.Remove(errorResponse.Error.Length - 1);
                MessageBox.Show($"Upload failed: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Something went wrong during file upload!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            if (File.Exists(path)) File.Delete(path);
        }
    }
}