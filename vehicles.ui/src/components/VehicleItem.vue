<template>
  <v-col cols="12" md="6" >
    <v-item>
      <v-dialog v-model="isDialogOpen" width="500">
        <v-card v-if="!isEmpty(selectedItem)">
          <v-card-title>{{ selectedItem.name }}</v-card-title>
          <v-card-subtitle>
            <v-img
              :src="require(`@/assets/items/${selectedItem.imageName}.jpg`)"
              :alt="selectedItem.name"
              contain
              height="300"
              max-width="500"
              @click="openDescription"
            />
          </v-card-subtitle>
          <v-card-text>{{ selectedItem.description }}</v-card-text>
        </v-card>
        <template v-slot:activator="{ }">
          <v-btn class="ma-2" width="150" height="150">
            <v-img
              :src="require(`@/assets/items/${vehicle.imageName}.jpg`)"
              :alt="vehicle.name"
              height="150"
              width="150"
              @click="openDescription"
            />
          </v-btn>
        </template>
      </v-dialog>
    </v-item>
  </v-col>
</template>

<script lang="ts">
import { VehicleItemInterface } from '@/store/modules/vehicle/types'
import { defineComponent, PropType, ref } from '@vue/composition-api'
import { isEmpty } from 'lodash'

export default defineComponent({
  name: 'VehicleItem',
  props: {
    vehicle: {
      required: true,
      type: Object as PropType<VehicleItemInterface>
    }
  },
  setup(props) {
    const selectedItem = ref<VehicleItemInterface>()
    const isDialogOpen = ref<boolean>(false)

    function openDescription() {
      selectedItem.value = props.vehicle
      isDialogOpen.value = !isEmpty(selectedItem.value)
    }

    return {
      isDialogOpen,
      isEmpty,
      openDescription,
      selectedItem
    }
  },
})
</script>
