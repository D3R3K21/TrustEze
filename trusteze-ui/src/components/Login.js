function Login() {

  //TODO:(drose) move URL to environment variable
    return (
      <a href="https://trusteze.auth.us-east-1.amazoncognito.com/login?client_id=3gn8kb63bta2jmkjhcnhtnb4q0&response_type=code&scope=email+openid+phone&redirect_uri=http%3A%2F%2Flocalhost%3A80%2Fauth">
        <button>Login</button>
      </a>
      );
}

export default Login;