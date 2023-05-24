import React from 'react';
import { Flex, Image, Text, useMediaQuery } from '@chakra-ui/react';

const InfoWithIcon: React.FC<SearchCardInfoRowProps> = ({
  icon,
  text,
  categoryText,
}) => {
  const isWithCategoryText = categoryText.length > 0;
  const [isLargerThanMobile] = useMediaQuery('(min-width: 468px)');
  return (
    <Flex flexDirection={isLargerThanMobile ? 'row' : 'column'} gap="8px">
      <Flex flexShrink="0">
        <Image src={icon} alt="" w="24px" h="24px" mr="6px" />
        {isWithCategoryText && (
          <Text variant="regular.bold" width="124px" whiteSpace="nowrap">
            {categoryText}
          </Text>
        )}
      </Flex>
      <Text>{text}</Text>
    </Flex>
  );
};

export default InfoWithIcon;

interface SearchCardInfoRowProps {
  icon: string;
  categoryText: string;
  text: string;
}