import type { Preview } from '@storybook/react';
import theme from '../src/assets/theme/index'

const preview: Preview = {
  parameters: {
    actions: { argTypesRegex: '^on[A-Z].*' },
    controls: {
      matchers: {
        color: /(background|color)$/i,
        date: /Date$/,
      },
    },
    chakra: {
      theme,
    },
  },
};

export default preview;