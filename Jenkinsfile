pipeline {
    agent any
    
    environment {
        CONTAINER_NAME = 'hihi.productapi'
    }

    stages {
        stage('Checkout') {
            steps {
                // Clean workspace before cloning
                deleteDir()

                // Clone the GitHub repository
                checkout scm
            }
        }

        stage('Stop and remove container + image old') {
            steps {
                script {
                    // sh "docker stop ${CONTAINER_NAME}"
                    // sh "docker container rm ${CONTAINER_NAME}"
                    // sh "docker image rm ${CONTAINER_NAME}"
                    sh "docker-compose down"
                }
            }
        }

        stage('Build and Run') {
            steps {
                script {
                    // Run Docker Compose
                    sh "docker-compose up -d"
                }
            }
        }

        // stage('Cleanup') {
        //     steps {
        //         script {
        //             // Stop and remove Docker Compose services
        //             sh "docker-compose down"
        //         }
        //     }
        // }
    }
}
