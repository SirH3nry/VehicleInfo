import Vue from 'vue'
import Vuetify from 'vuetify/lib/framework'

Vue.use(Vuetify)

export default new Vuetify({
  theme: {
    themes: {
      light: {
        primary: '#b3e5fc',
        secondary: '#8465ff',
        accent: '#b2a1ff'
      },
    },
  },
})
