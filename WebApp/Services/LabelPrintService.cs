using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Services
{
    public class LabelPrintService
    {
        private readonly HttpClient _httpClient;

        public LabelPrintService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PrintJob>> GetPrintQueueAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<PrintJob>>("api/printer/printqueue");
        }

        public async Task<bool> CreatePrintJobAsync(PrintJob printJob)
        {
            var response = await _httpClient.PostAsJsonAsync("api/printer/printjob", printJob);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CancelPrintJobAsync(int jobId)
        {
            var response = await _httpClient.DeleteAsync($"api/printer/printjob/{jobId}");
            return response.IsSuccessStatusCode;
        }
    }

    public class PrintJob
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}