namespace BusinessAccessLayer.Services.Services.Login
{
    public interface IServiceLogin
    {
        public string Authenticate(string userId, string password);
        
        
    }
}
