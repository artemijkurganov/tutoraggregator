import { Outlet } from 'react-router-dom';
import Header from './Header';
import Footer from './Footer';
import { Container } from '@chakra-ui/react';
import { UserContext } from '../../contexts/UserContext';
import { LoadBar } from '../../pages/sharedComponents/LoadBar/LoadBar';
import { useSearchValues, useUser } from './hooks';
import React, { useMemo } from 'react';
import { SearchStateContext } from '../../contexts/SearchStateContext';

const BaseLayout: React.FC = () => {
  const { user, setUser, removeUser, isLoading, isUserAuth } = useUser();
  const userProviderValues = useMemo(
    () => ({ user, setUser, removeUser, isAuthorized: isUserAuth }),
    [user, setUser, removeUser, isUserAuth, isLoading]
  );

  const { setSearchValues, searchValues, hasSearchValues } = useSearchValues();
  const searchProviderValues = useMemo(
    () => ({ setSearchValues, searchValues, hasSearchValues }),
    [setSearchValues, searchValues, hasSearchValues]
  );

  if (isLoading) return <LoadBar description={'Загружаем данные'} />;
  return (
    <UserContext.Provider value={userProviderValues}>
      <SearchStateContext.Provider value={searchProviderValues}>
        <Header />
        <Container padding={'0vh 5vw 16vh 5vw'} maxW={'100%'}>
          <Outlet />
        </Container>
        <Footer />
      </SearchStateContext.Provider>
    </UserContext.Provider>
  );
};

export default BaseLayout;
