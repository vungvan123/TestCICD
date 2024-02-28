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
    
    environment {
        DOCKER_COMPOSE_VERSION = '2.24.5'
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
                echo "Checked out code to: ${env.WORKSPACE}/CICD"
            }
        }

        stage('Build and Run Docker Compose') {
            steps {
                script {
                    // Install Docker Compose
                    sh "sudo curl -L https://github.com/docker/compose/releases/download/${DOCKER_COMPOSE_VERSION}/docker-compose-$(uname -s)-$(uname -m) -o /usr/local/bin/docker-compose"
                    sh "sudo chmod +x /usr/local/bin/docker-compose"

                    // Run Docker Compose
                    sh "sudo docker-compose up -d"
                }
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
