import React from 'react';

const rootElement = document.getElementById('root');
import { createRoot } from 'react-dom/client';

import { RouterProvider } from 'react-router-dom';
import router from './routes/browserRouter';
import { ChakraProvider } from '@chakra-ui/react';
import theme from './assets/theme/index';
import { queryClient } from './query';
import { QueryClientProvider } from 'react-query';

const root = createRoot(rootElement);

root.render(
  <React.StrictMode>
    <ChakraProvider theme={theme}>
      <QueryClientProvider client={queryClient}>
        <RouterProvider router={router} />
      </QueryClientProvider>
    </ChakraProvider>
  </React.StrictMode>
);
