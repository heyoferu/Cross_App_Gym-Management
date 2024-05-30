namespace App.ViewModels;

public class LoginViewModel : ViewModelBase
{
    public string? Username{ get; set; }
    public string? Password { get; set; }
    
    private string? _token = "";
    private bool _isTokenVisible = false;
    
    private string? _loginMsg = "";
    private bool _isLoginMsgVisible = false;
    
}