import { Navigate, Outlet, useSearchParams } from 'react-router-dom'
import { useEffect, useState } from 'react';
import AuthenticatedHeader from './components/AuthenticatedHeader';

const PrivateRoutes = () => {

    const [searchParams, setSearchParams] = useSearchParams();
    const session_jwt = localStorage.getItem('jwt')
    const [jwt, setJwt] = useState(searchParams.get("jwt"));
    if(!session_jwt){
        console.log('no session jwt');
    }
    
    console.log('JWT Before SET: ', jwt)
    
    
    //TODO:(drose) store code as 'token' in state and check that, remove from query param before redirecting to /home
    useEffect(() => {
      
      if (jwt) {
        
        searchParams.delete('jwt')
        setSearchParams(searchParams); 
      }
    }, [])

return (
    jwt ? <><AuthenticatedHeader/><Outlet/></> : <Navigate to='/login'/>
  )
}

export default PrivateRoutes;