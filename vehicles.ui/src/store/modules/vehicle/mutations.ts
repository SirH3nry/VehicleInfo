import { MutationTree } from 'vuex'
import { VehicleItemInterface, VehicleStoreInterface } from '@/store/modules/vehicle/types'

export class VehicleMutations {
  public static SET_VEHICLES = 'SET_VEHICLES'
}

export const mutations: MutationTree<VehicleStoreInterface> = {
  SET_VEHICLES(state: VehicleStoreInterface, payload: { vehicles: Array<VehicleItemInterface> }) {
    state.items = payload.vehicles
  }
}

export default mutations
