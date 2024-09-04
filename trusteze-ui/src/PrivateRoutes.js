import { Navigate, Outlet, useSearchParams } from 'react-router-dom'
import { useEffect } from 'react';

const PrivateRoutes = () => {

  const [searchParams, setSearchParams] = useSearchParams();

    const code = searchParams.get("code")
    console.log('Authorize code: ', code)

    //TODO:(drose) store code as 'token' in state and check that, remove from query param before redirecting to /home
    // useEffect(() => {
      
    //   if (code) {
    //     searchParams.delete('code')
    //     setSearchParams(searchParams); 
    //   }
    // }, [])

return (
    code ? <Outlet/> : <Navigate to='/login'/>
  )
}

export default PrivateRoutes;