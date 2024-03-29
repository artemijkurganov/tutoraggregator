import * as React from 'react';
import { HStack, VStack } from '@chakra-ui/react';
import { TimeBox } from './TimeBox';
import { SlotContext } from './contexts/SlotContext';
import { SlotInfo } from './SlotInfo';
import { useMemo } from 'react';
import { LessonType, V1ContactsDto } from '../../api/models';
import { DateBox } from './DateBox';
import { getTimeFromDate } from '../../utils/datetime';

export const Slot: React.FC<SlotProps> = (props) => {
  const providerValue = useMemo(
    () => ({
      ...props,
      timeRange: `${getTimeFromDate(props.startDate)} - ${getTimeFromDate(
        props.endDate
      )}`,
      tutorName: props.tutorName,
      startDate: new Date(props.startDate),
      endDate: new Date(props.endDate),
    }),
    [props]
  );

  const lightBackground = 'linear-gradient(90deg, #7C98AA 65px, #FFFFFF 65px)';
  const darkBackground = 'linear-gradient(90deg, #2A363D 65px, #FFFFFF 65px)';
  const lightBorderColor = 'custom.blue.200';
  const darkBorderColor = 'custom.blue.300';

  const isDateBoxVisible = !(
    props.variant === SlotVariant.tutorCalendar ||
    props.variant === SlotVariant.studentCalendar
  );
  return (
    <>
      <SlotContext.Provider value={providerValue}>
        <VStack
          borderRadius="0 10px 10px 0"
          borderWidth="2px"
          borderColor={
            props.variant === SlotVariant.activeCloseList ||
            props.variant === SlotVariant.activeAllList
              ? darkBorderColor
              : props.variant === SlotVariant.tutorCalendar
              ? props.bookedBy === BookedBy.someone
                ? darkBorderColor
                : lightBorderColor
              : props.bookedBy !== BookedBy.someone
              ? darkBorderColor
              : lightBorderColor
          }
          overflow="hidden"
          width="100%"
          spacing={'0'}
        >
          {isDateBoxVisible && <DateBox />}
          <HStack
            w="100%"
            spacing="0"
            background={
              props.variant === SlotVariant.activeCloseList ||
              props.variant === SlotVariant.activeAllList
                ? darkBackground
                : props.variant === SlotVariant.tutorCalendar
                ? props.bookedBy === BookedBy.someone
                  ? darkBackground
                  : lightBackground
                : props.bookedBy !== BookedBy.someone
                ? darkBackground
                : lightBackground
            }
          >
            <TimeBox />
            <SlotInfo />
          </HStack>
        </VStack>
      </SlotContext.Provider>
    </>
  );
};

export type SlotProps = {
  startDate: Date;
  endDate: Date;
  lessonId: string;
  tutorId: string;
  bookedBy: BookedBy;
  type: LessonType;
  price: number;
  tutorName: string;
  studentName: string;
  variant: SlotVariant;
  contacts: V1ContactsDto[];
};

export enum SlotVariant {
  tutorCalendar = 'Tutor Calendar',
  studentCalendar = 'Student Calendar',
  activeCloseList = 'Active close',
  activeAllList = 'Active all',
  pastList = 'Past List',
  canceledList = 'CanceledList',
}

export enum BookedBy {
  nobody = 'Nobody',
  someone = 'Someone',
  current = 'Current',
}
