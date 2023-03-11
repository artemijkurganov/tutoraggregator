import {
  Box,
  Button,
  Checkbox,
  Flex,
  HStack,
  Link,
  Stack,
  useBreakpointValue,
  VStack,
} from '@chakra-ui/react';
import React from 'react';
import { PasswordField } from './components/PasswordField';
import { OAuthButtons } from './components/OAuthButtons';
import { Header } from './components/Header';
import { DividerWithOr } from './components/DividerWithOr';
import { EmailField } from './components/EmailField';
import { TutorOrStudentSwitchField } from './components/TutorOrStudentSwitchField';
import { PhoneNumberField } from './components/PhoneNumberField';
import { NameSurnameField } from './components/NameSurnameField';
import { Form, Formik, FormikValues } from 'formik';
import { LoginSuggestion } from './components/LoginSuggestion';

const initialValues = {
  name: '',
  surname: '',
  phoneNumber: '',
  isTutor: false,
  email: '',
  password: '',
};

export const SignupPage = () => {
  const isDesktop = useBreakpointValue({ base: false, lg: true });

  const onSubmit = (values: FormikValues) => console.log(values);

  return (
    <Flex background={'white'}>
      <VStack margin={'20px'} width={'100%'}>
        <Header title={'Зарегистрировать аккаунт'} />
        <Box
          py={{ base: '0', sm: '8' }}
          px={{ base: '4', sm: '10' }}
          width={isDesktop ? '50%' : '90%'}
          bg="white"
          borderWidth="2px"
          borderRadius={{ base: 'none', sm: 'xl' }}
        >
          <OAuthButtons />
          <DividerWithOr />
          <Formik initialValues={initialValues} onSubmit={onSubmit}>
            <Form>
              <NameSurnameField />
              <PhoneNumberField />
              <TutorOrStudentSwitchField />
              <Stack spacing="6">
                <Stack spacing="5">
                  <EmailField />
                  <PasswordField />
                </Stack>
                <HStack justify="space-between">
                  <Checkbox>
                    Принимаю{' '}
                    <Link color="teal.500" href="#">
                      условия сервиса.
                    </Link>
                  </Checkbox>
                </HStack>
                <Stack spacing="6">
                  <Button
                    variant={'solid'}
                    size={'lg'}
                    colorScheme={'blue'}
                    type="submit"
                  >
                    Зарегистрироваться
                  </Button>
                </Stack>
                <LoginSuggestion />
              </Stack>
            </Form>
          </Formik>
        </Box>
      </VStack>
    </Flex>
  );
};
