import Vue from 'vue'
import Vuex from 'vuex'
import { RootState } from '@/store/types'
import vehicle from '@/store/modules/vehicle'

Vue.use(Vuex)

export default new Vuex.Store<RootState>({
  modules: {
    vehicle
  },
})
