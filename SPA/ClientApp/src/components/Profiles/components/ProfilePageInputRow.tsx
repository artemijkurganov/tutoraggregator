import * as React from 'react';
import { FormControl, FormLabel, Flex, Input } from '@chakra-ui/react';
import { useField } from 'formik';

export const ProfilePageInputRow = (props: ProfilePageInputProps) => {
  const [field] = useField({ name: props.name });
  return (
    <Flex width={'100%'} margin={'0 0 10px 0'} align={'center'}>
      <FormControl
        display={'flex'}
        alignItems={'center'}
        isRequired={props.isRequired}
      >
        <FormLabel
          fontSize={'xl'}
          margin={'auto 10px auto 0'}
          flex={'0 0 130px'}
          textAlign={'right'}
        >
          {props.label}
        </FormLabel>
        <Input
          placeholder={props.placeholder}
          value={props.value}
          bg="white"
          color={'#000000'}
          width={'100%'}
          fontSize={'lg'}
          size={'md'}
          isDisabled={props.isDisabled}
          {...field}
        />
        {props.tooltip}
      </FormControl>
    </Flex>
  );
};

type ProfilePageInputProps = {
  placeholder?: string;
  label: string;
  isDisabled: boolean;
  isRequired: boolean;
  tooltip: JSX.Element[];
  value?: string;
  name: string;
};
