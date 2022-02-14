import { ActionTree } from 'vuex'
import axios from 'axios'
import { RootState } from '@/store/types'
import { VehicleItemApiResponseInterface, VehicleItemInterface, VehicleStoreInterface } from '@/store/modules/vehicle/types'
import { VehicleMutations } from '@/store/modules/vehicle/mutations'
import { isEmpty } from 'lodash'

export class VehicleActions {
  /** Loads all vehicles from the api. */
  public static LoadVehicles = 'vehicle/loadVehicles'
}

export const actions: ActionTree<VehicleStoreInterface, RootState> = {
  loadVehicles({ commit }) {
    console.info('loading vehicles...')
    axios
      .get<Array<VehicleItemApiResponseInterface>>('http://localhost:14651/api/vehicles')
      .then<Array<VehicleItemInterface>>((response) => {
        console.info('api callout completed', response)
        if (isEmpty(response?.data)) throw new Error('response is empty')
        const vehicles = response.data
          .map(v => {
            return {
              description: v.description,
              id: v.id,
              imageName: v.imageName,
              name: v.name
            } as VehicleItemInterface
          })

        commit(VehicleMutations.SET_VEHICLES, { vehicles: vehicles })
        console.info('api callout successful', response)
        return vehicles
      })
      .catch(e => console.error('vehicle/loadVehicles :: failed', e))

    // Test data:
    // const payload = {
    //   vehicles: [
    //     { id: 0, name: 'Ford Taurus', imageName: 'ford-taurus', description: 'The best car ever made, second only to the wagon edition.' } as VehicleItemInterface,
    //     { id: 1, name: 'Honda Civic', imageName: 'honda-civic', description: 'Survives for longer than 100,000 miles.' } as VehicleItemInterface,
    //     { id: 2, name: 'Jeep Rubicon', imageName: 'jeep-rubicon', description: 'Cool looking car, expensive parts.' } as VehicleItemInterface,
    //     { id: 3, name: 'Tesla Model 3', imageName: 'tesla-model3', description: 'Electric vehicle, still not quite affordable.' } as VehicleItemInterface
    //   ]
    // }
  }
}

export default actions
