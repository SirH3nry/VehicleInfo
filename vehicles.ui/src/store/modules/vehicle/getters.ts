import { GetterTree } from 'vuex'
import { RootState } from '@/store/types'
import { VehicleStoreInterface } from './types'

export class VehicleGetters {
  public static All = 'vehicle/getAllVehicles'
}

export const getters: GetterTree<VehicleStoreInterface, RootState> = {
  getAllVehicles: (state: VehicleStoreInterface) => {
    return state.items
  }
}

export default getters
