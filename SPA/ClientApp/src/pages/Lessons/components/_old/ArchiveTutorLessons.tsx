import * as React from 'react';
import { Box, Flex, useBreakpointValue, Heading } from '@chakra-ui/react';
import { LessonsBoxRow } from './LessonsBoxRow';
export const ArchiveTutorLessons = () => {
  const isDesktop = useBreakpointValue({ base: false, lg: true });
  return (
    <Box
      width={'100%'}
      shadow={'md'}
      borderRadius={'5px'}
      borderWidth={'1px'}
      bg="#C4C4C4"
    >
      <Flex
        padding={isDesktop ? '1.5em' : '1em'}
        direction={isDesktop ? 'row' : 'column'}
      >
        <Flex width={'100%'} align={'left'} direction={'column'} margin={'0'}>
          <Heading size={'md'} margin={'0 0 1em 0'}>
            Архивные записи ваших учеников
          </Heading>
          <LessonsBoxRow
            personName={'Алексей Соколков'}
            datetime={new Date(2023, 0, 22, 11, 0).getTime()}
            isLink={false}
            isRatable={false}
            isCancellable={false}
          />
          <LessonsBoxRow
            personName={'Артемий Курганов'}
            datetime={new Date(2023, 0, 20, 11, 30).getTime()}
            isLink={false}
            isRatable={false}
            isCancellable={false}
          />
          <LessonsBoxRow
            personName={'Диляра Фатыхова'}
            datetime={new Date(2023, 0, 19, 14, 30).getTime()}
            isLink={false}
            isRatable={false}
            isCancellable={false}
          />
        </Flex>
      </Flex>
    </Box>
  );
};
