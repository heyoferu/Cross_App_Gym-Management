using ReactiveUI;

namespace App.ViewModels;

public class LoginViewModel : ViewModelBase
{
    public string? Username{ get; set; }
    public string? Password { get; set; }
    
    private string? _token = "";
    private bool _isTokenVisible = false;
    
    private string? _loginMsg = "";
    private bool _isLoginMsgVisible = false;

    public string? Token
    {
        get => _token;
        set => this.RaiseAndSetIfChanged(ref _token, value);
    }

    public bool IsTokenVisible
    {
        get => _isTokenVisible;
        set => this.RaiseAndSetIfChanged(ref _isTokenVisible, value);
    }

    public string? LoginMsg
    {
        get => _loginMsg;
        set => this.RaiseAndSetIfChanged(ref _loginMsg, value);
    }

    public bool IsLoginMsgVisible
    {
        get => _isLoginMsgVisible;
        set => this.RaiseAndSetIfChanged(ref _isLoginMsgVisible, value);
    }
    
}