namespace YtMovieApis.Models.Domain
{
    public class TokenInfo
    {
        public int Id { get; set; }
        public string Usename { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiry { get; set; }
    }
}
