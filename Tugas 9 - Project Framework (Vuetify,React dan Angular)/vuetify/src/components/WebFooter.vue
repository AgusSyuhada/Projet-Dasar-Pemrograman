<template>
    <v-footer id="footer" app bottom absolute padless dark>
        <v-card class="flex" flat tile>
            <v-card-title class="teal">
                <strong class="subheading">Get connected with us on social networks!</strong>
                <v-spacer></v-spacer>
                <v-btn
                    v-for="icon in icons"
                    :key="icon"
                    class="mx-5"
                    dark
                    icon
                >
                    <v-icon size="24px">{{ icon }}</v-icon>
                </v-btn>
            </v-card-title>

            <v-layout>
                <v-card-actions id="copyright">
                    <p>©{{ new Date().getFullYear() }} - <strong>Universitas Riau</strong></p>
                </v-card-actions>
            </v-layout>
            
        </v-card>
    </v-footer>
</template>

<script>
    export default {
        data: () => ({
           icons: [
            'mdi-facebook',
            'mdi-twitter',
            'mdi-google-plus',
            'mdi-linkedin',
            'mdi-instagram'
           ] 
        })
    }
</script>

<style>
    #footer .teal{
        background-color: darkgreen;
    }
    #copyright  {
        justify-content: center;
    }
</style>