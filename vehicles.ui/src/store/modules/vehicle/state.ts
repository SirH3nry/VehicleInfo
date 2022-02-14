import { VehicleItemInterface, VehicleStoreInterface } from '@/store/modules/vehicle/types'

export const state: VehicleStoreInterface = {
  items: [] as Array<VehicleItemInterface>,
}

export default state
