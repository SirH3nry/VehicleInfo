<template>
  <v-app class="d-flex justify-space-around">
    <v-app-bar app color="primary">
      <div class="d-flex align-center">
        <v-img
          alt="Vuetify Logo"
          class="shrink mr-2"
          contain
          :src="require('@/assets/logo.svg')"
          transition="scale-transition"
          width="40"
        />
      </div>
    </v-app-bar>

    <v-main id="page-container">
      <VehicleGrid />
    </v-main>
  </v-app>
</template>

<script lang="ts">
import { defineComponent } from '@vue/composition-api'
import VehicleGrid from '@/components/VehicleGrid.vue'

export default defineComponent({
  name: 'App',
  components: {
    VehicleGrid
  }
})
</script>

<style lang="css">
#page-container {
  margin-left: auto;
  margin-right: auto;
  flex: none;
  max-width: 400px;
  width: 100%;
}
</style>
