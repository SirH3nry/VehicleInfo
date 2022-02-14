import { Module } from 'vuex'
import { RootState } from '@/store/types'
import actions from '@/store/modules/vehicle/actions'
import getters from '@/store/modules/vehicle/getters'
import mutations from '@/store/modules/vehicle/mutations'
import state from '@/store/modules/vehicle/state'
import { VehicleStoreInterface } from '@/store/modules/vehicle/types'

export const vehicle: Module<VehicleStoreInterface, RootState> = {
  namespaced: true,
  state,
  actions,
  mutations,
  getters
}

export default vehicle
