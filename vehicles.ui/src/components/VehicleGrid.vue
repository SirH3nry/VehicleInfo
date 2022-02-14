<template>
  <v-card class="d-flex align-center justify-space-around mt-4 pa-4 text-center">
    <v-item-group v-model="model">
      <v-row v-if="!isEmpty(vehicles)">
        <VehicleItem v-for="item in vehicles" :key="item.id" :vehicle="item" />
      </v-row>
    </v-item-group>
  </v-card>
</template>

<script lang="ts">
import { defineComponent, computed, ref } from '@vue/composition-api'
import { isEmpty } from 'lodash'
import VehicleItem from '@/components/VehicleItem.vue'
import store from '@/store'
import { VehicleActions } from '@/store/modules/vehicle/actions'
import { VehicleGetters } from '@/store/modules/vehicle/getters'
import { VehicleItemInterface } from '@/store/modules/vehicle/types'

export default defineComponent({
  name: 'VehicleGrid',
  components: {
    VehicleItem
  },
  setup() {
    const model = ref<number>(0)
    const vehicles = computed<Array<VehicleItemInterface>>(() => store.getters[VehicleGetters.All])

    store.dispatch(VehicleActions.LoadVehicles)

    return {
      isEmpty,
      model,
      vehicles,
    }
  },
})
</script>
