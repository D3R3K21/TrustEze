function Login() {

  //TODO:(drose) move URL to environment variable
    return (
      <a href="https://trusteze.auth.us-east-1.amazoncognito.com/login?client_id=3gn8kb63bta2jmkjhcnhtnb4q0&response_type=code&scope=email+openid+phone&redirect_uri=https%3A%2F%2Fapi.trusteze.co%2Fauth">
        <button>Login - Styled By Derek with 0 css just for Britni</button>
      </a>
      );
}

export default Login;