<template>
    <v-toolbar color="green darken-4" dark>
        <v-app-bar-nav-icon @clik.stop="drawer = !drawer"></v-app-bar-nav-icon>
        <div class="hidden-sm-and-down">
            <v-btn text>Home</v-btn>
            <v-btn text>Profile</v-btn>
            <v-btn text>Unit/Lembaga</v-btn>
            <v-btn text>Akademik</v-btn>
            <v-btn text>Dokumen</v-btn>
            <v-btn text>Gallery</v-btn>
            <v-btn text>Peta</v-btn>
            <v-btn text>Video Profil</v-btn>
            <router-link to="/login">
                <v-btn text>Kontak</v-btn>
            </router-link>
        </div>
        <div class="hidden-sm-and-down">
        <v-navigation-drawer
          v-model="drawer"
          absolute
          temporary
          height="800px">
            <v-list class="pa-1">
                <v-list-item avatar>
                    <v-list-item-avatar>
                        <v-img src="https://randomuser.me/api/portraits/men/85.jpg"></v-img>
                    </v-list-item-avatar>

                    <v-list-item-content>
                        <v-list-item-title>Jonh Leider</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>
            </v-list>

            <v-list class="pt-0" dense>
                <v-divider></v-divider>

                <v-list-item
                    v-for="item in items"
                    :key="item.title">
                    <v-list-item-action>
                        <v-icon>{{ item.icon }}</v-icon>
                    </v-list-item-action>

                    <v-list-item-content>
                        <v-list-item-title>{{ item.title}}</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>
            </v-list>
        </v-navigation-drawer>
        </div>
    </v-toolbar>
</template>

<script>
    export default {
        data () {
            return {
                drawer: null,
                item: [
                    { title: 'Home', icon: 'dashboard' },
                    { totle: 'About', icon: 'question_answer' }
                ]
            }
        }
    }
</script>