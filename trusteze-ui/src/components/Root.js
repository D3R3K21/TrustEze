import { Outlet } from 'react-router-dom'
import Header from './AuthenticatedHeader';

function Root() {
return(
<>
<Header/>
<Outlet/>
</>
);
}