using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Services
{
    public class AuditLogService
    {
        private readonly HttpClient _httpClient;

        public AuditLogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AuditLog>> GetAuditLogsAsync(string actionFilter = "")
        {
            var url = string.IsNullOrEmpty(actionFilter)
                ? "api/report"
                : $"api/report?filter={actionFilter}";

            return await _httpClient.GetFromJsonAsync<List<AuditLog>>(url);
        }
    }

    public class AuditLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Details { get; set; }
        public DateTime Timestamp { get; set; }
    }
}