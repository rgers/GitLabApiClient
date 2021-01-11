using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Models.Releases.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Commits.Responses
{
    public sealed class Commit
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("short_id")]
        public string ShortId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }
        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }
        [JsonProperty("authored_date")]
        public DateTime AuthoredDate { get; set; }
        [JsonProperty("committer_name")]
        public string CommitterName { get; set; }
        [JsonProperty("committer_email")]
        public string CommitterEmail { get; set; }
        [JsonProperty("committed_date")]
        public DateTime CommittedDate { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("parent_ids")]
        public List<string> ParentIds { get; } = new List<string>();
        [JsonProperty("stats")]
        public CommitStats Stats { get; set; }
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }

    public sealed class CommitStats
    {
        [JsonProperty("additions")]
        public int Additions { get; set; }
        [JsonProperty("deletions")]
        public int Deletions { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
