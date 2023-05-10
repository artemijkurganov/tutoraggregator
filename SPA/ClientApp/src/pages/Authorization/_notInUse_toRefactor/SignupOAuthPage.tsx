import {
  ChakraProvider,
  Box,
  Button,
  Checkbox,
  Flex,
  FormControl,
  FormLabel,
  Switch,
  Link,
  VStack,
  HStack,
  Input,
  Stack,
  Text,
  InputLeftAddon,
  InputGroup,
  useBreakpointValue,
} from '@chakra-ui/react';
import Theme from '../../../assets/theme';
import { Header } from '../components/Header';

export const SignupOAuthPage = () => {
  const isDesktop = useBreakpointValue({ base: false, lg: true });
  return (
    <ChakraProvider theme={Theme}>
      <Flex background={'gray.50'} height={'100vh'}>
        <VStack margin={'80px'} width={'100%'}>
          <Header title={'Продолжение регистрации'} />
          <Box
            py={{ base: '0', sm: '8' }}
            px={{ base: '4', sm: '10' }}
            width={isDesktop ? '50%' : '90%'}
            bg="white"
            borderRadius={{ base: 'none', sm: 'xl' }}
          >
            <Stack spacing="6">
              <Stack spacing="5">
                <FormControl>
                  <FormLabel htmlFor="email">Имя и фамилия</FormLabel>
                  <HStack>
                    <Input id="name" type="text" placeholder="Введите имя" />
                    <Input
                      id="surname"
                      type="text"
                      placeholder="Введите фамилию"
                    />
                  </HStack>
                </FormControl>
                <FormControl>
                  <FormLabel htmlFor="email">Телефон</FormLabel>
                  <HStack>
                    <InputGroup>
                      <InputLeftAddon children="+7" />
                      <Input id="tel" type="tel" placeholder="9991234567" />
                    </InputGroup>
                  </HStack>
                </FormControl>
                <FormControl>
                  <FormLabel htmlFor="email">Тип аккаунта</FormLabel>
                  <HStack justify="center">
                    <Text fontSize="md" whiteSpace="nowrap" color="muted">
                      Ученик
                    </Text>
                    <Switch
                      size="lg"
                      colorScheme="Gray 200"
                      id="isRequired"
                      isRequired
                    />
                    <Text fontSize="md" whiteSpace="nowrap" color="muted">
                      Репетитор
                    </Text>
                  </HStack>
                </FormControl>
              </Stack>
              <HStack justify="space-between">
                <Checkbox>
                  Принимаю <Link color="teal.500">условия сервиса.</Link>
                </Checkbox>
              </HStack>
              <Stack spacing="6">
                <Button variant={'solid'} size={'lg'} colorScheme={'blue'}>
                  Зарегистрироваться
                </Button>
              </Stack>
            </Stack>
          </Box>
        </VStack>
      </Flex>
    </ChakraProvider>
  );
};