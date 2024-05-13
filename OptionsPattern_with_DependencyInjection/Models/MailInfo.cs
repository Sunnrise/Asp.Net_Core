namespace OptionsPattern_with_DependencyInjection.Models
{
    public class MailInfo
    {
        public string MailHost { get; set; }
        public string MailPort { get; set; }
        public EmailInfo EmailInfo { get; set; }


}
    public class EmailInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
