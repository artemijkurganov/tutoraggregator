import * as React from 'react';
import {
  VStack,
  Text,
  TabPanel,
  TabPanels,
  Tab,
  Tabs,
  TabList,
} from '@chakra-ui/react';
import searchIcon from '../../../assets/images/search_icon_bg.png';
import { FormBody } from './FormBody';
import { Form, Formik, FormikValues } from 'formik';
import { createSearchParams, useNavigate } from 'react-router-dom';
import { SEARCH_PAGE } from '../../../routes/routePaths';

export const MainSearchBox: React.FC = ({}) => {
  const initValues: FormikValues = {
    district: '',
    subject: '',
  };

  const navigate = useNavigate();
  const onSubmit = (values: FormikValues) => {
    navigate({
      pathname: SEARCH_PAGE,
      search: createSearchParams(values).toString(),
    });
  };

  return (
    <VStack
      margin={'0 -5vw 0 -5vw'}
      padding={'16px'}
      bg="custom.blue.100"
      width={'calc(100% + 10vw)'}
      spacing={'20px'}
      backgroundImage={searchIcon}
      backgroundPosition={'right bottom'}
      backgroundRepeat={'no-repeat'}
      backgroundSize={'14em'}
    >
      <Text variant={'brand.h1'} color={'custom.blue.300'}>
        Найдем репетиторов под твои цели
      </Text>
      <Tabs
        variant={'soft-rounded'}
        size={'sm'}
        colorScheme="gray"
        width={'100%'}
      >
        <TabList justifyContent={'center'}>
          <Tab>Офлайн занятия</Tab>
          <Tab>Онлайн занятия</Tab>
        </TabList>
        <TabPanels>
          <TabPanel padding={'10px 20% 6px 20%'}>
            <Formik initialValues={initValues} onSubmit={onSubmit}>
              <Form>
                <FormBody />
              </Form>
            </Formik>
          </TabPanel>
          {/*<TabPanel padding={'10px 20% 6px 20%'}>*/}
          {/*  <HStack justify={'center'} width={'100%'} align={'flex-end'}>*/}
          {/*    <SelectOptions*/}
          {/*      label={'Предмет'}*/}
          {/*      options={REMOVE_removeDuplicates(*/}
          {/*        subjectsData.map((subject) => subject.description)*/}
          {/*      )}*/}
          {/*      name="subject"*/}
          {/*      placeholder="Любой"*/}
          {/*    />*/}
          {/*    <Button*/}
          {/*      variant="green"*/}
          {/*      minWidth={'160px'}*/}
          {/*      type="submit"*/}
          {/*      // isLoading={isRefetching}*/}
          {/*    >*/}
          {/*      Найти*/}
          {/*    </Button>*/}
          {/*  </HStack>*/}
          {/*</TabPanel>*/}
        </TabPanels>
      </Tabs>
    </VStack>
  );
};
