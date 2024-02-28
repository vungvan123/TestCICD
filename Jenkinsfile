// pipeline {
//     agent any
//     stages {
//         stage('Build') {
//             steps {
//                 sh 'echo "Hello task1"'
//             }
//         }
//         stage('Test') {
//             steps {
//                 echo 'Run some unit tests'
//                 sh 'echo "Run an integration test"'
//             }
//         }
//         stage('Deploy') {
//             steps {
//                 sh 'echo "Deploy application"'
//             }
//         }
//     }
// }

pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                checkout scm
                echo "Checked out code to: ${env.WORKSPACE}"
            }
        }

        stage('Build and Push Docker Image') {
            steps {
                // dir("${env.WORKSPACE}") {
                //     sh 'docker-compose up -d'
                // }
                sh 'docker-compose up -d'
            }
        }
    }

    post {
        success {
            echo 'Pipeline succeeded! Perform additional tasks...'
        }
        failure {
            echo 'Pipeline failed! Notify stakeholders...'
        }
    }
}
